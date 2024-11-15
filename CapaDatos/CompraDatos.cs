using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaDatos
{
    public class CompraDatos
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();

        /* CREATE TYPE DetalleCompraTipo AS TABLE (
                IdProducto INT,
                PrecioCompra DECIMAL(10, 2),
                PrecioVenta DECIMAL(10, 2),
                Cantidad INT
            );
            GO
            CREATE PROCEDURE RegistrarCompra
                @IdUsuario INT,
                @IdProveedor INT,
                @TipoDocumento VARCHAR(50),
                @NumeroDocumento VARCHAR(50),
                @MontoTotal DECIMAL(30, 3),
                @DetalleCompra DetalleCompraTipo READONLY
            AS
            BEGIN
                -- Iniciar una transacción
                BEGIN TRANSACTION;

                BEGIN TRY
                    -- Paso 1: Insertar registro en la tabla COMPRA
                    DECLARE @IdCompra INT;
        
                    INSERT INTO COMPRA (IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
                    VALUES (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal, GETDATE());

                    -- Obtener el IdCompra recién creado
                    SET @IdCompra = SCOPE_IDENTITY();

                    -- Paso 2: Insertar detalles de compra en DETALLE_COMPRA
                    INSERT INTO DETALLE_COMPRA (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, FechaRegistro)
                    SELECT 
                        @IdCompra, 
                        IdProducto, 
                        PrecioCompra, 
                        PrecioVenta, 
                        Cantidad, 
                        GETDATE()
                    FROM @DetalleCompra;

                    -- Paso 3: Actualizar el stock de cada producto en la tabla PRODUCTO
                    UPDATE P
                    SET P.Stock = P.Stock + D.Cantidad
                    FROM PRODUCTO P
                    INNER JOIN @DetalleCompra D ON P.IdProducto = D.IdProducto;

                    -- Confirmar transacción
                    COMMIT TRANSACTION;
        
                    PRINT 'Compra registrada exitosamente con IdCompra: ' + CAST(@IdCompra AS VARCHAR);

                END TRY
                BEGIN CATCH
                    -- Revertir la transacción en caso de error
                    ROLLBACK TRANSACTION;
                    PRINT 'Error al registrar la compra: ' + ERROR_MESSAGE();
                END CATCH
            END;
            GO



            -- Declarar y llenar la tabla de detalles de compra
            DECLARE @DetalleCompra DetalleCompraTipo;

            INSERT INTO @DetalleCompra (IdProducto, PrecioCompra, PrecioVenta, Cantidad)
            VALUES (1, 50.00, 70.00, 10), -- Producto 1, PrecioCompra 50, PrecioVenta 70, Cantidad 10
                   (2, 30.00, 50.00, 5);  -- Producto 2, PrecioCompra 30, PrecioVenta 50, Cantidad 5

            -- Llamar al procedimiento almacenado
            EXEC RegistrarCompra 
                @IdUsuario = 1, 
                @IdProveedor = 2, 
                @TipoDocumento = 'Factura', 
                @NumeroDocumento = 'F-001-000123',
                @MontoTotal = 800.00,
                @DetalleCompra = @DetalleCompra;
             */

        // Método para registrar una compra en la base de datos
        public void RegistrarCompra(CompraClass compra)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    using (SqlCommand cmd = new SqlCommand("RegistrarCompra", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdUsuario", compra.IdUsuario);
                        cmd.Parameters.AddWithValue("@IdProveedor", compra.IdProveedor);
                        cmd.Parameters.AddWithValue("@TipoDocumento", compra.TipoDocumento);
                        cmd.Parameters.AddWithValue("@NumeroDocumento", compra.NumeroDocumento);
                        cmd.Parameters.AddWithValue("@MontoTotal", compra.MontoTotal);

                        DataTable dtDetalleCompra = new DataTable();
                        dtDetalleCompra.Columns.Add("IdProducto", typeof(int));
                        dtDetalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
                        dtDetalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
                        dtDetalleCompra.Columns.Add("Cantidad", typeof(int));

                        foreach (CompraClass.DetalleCompra detalle in compra.Detalles)
                        {
                            dtDetalleCompra.Rows.Add(detalle.IdProducto, detalle.PrecioCompra, detalle.PrecioVenta, detalle.Cantidad);
                        }

                        SqlParameter paramDetalleCompra = new SqlParameter();
                        paramDetalleCompra.ParameterName = "@DetalleCompra";
                        paramDetalleCompra.SqlDbType = SqlDbType.Structured;
                        paramDetalleCompra.TypeName = "DetalleCompraTipo"; // Nombre del tipo de tabla definido en la BD
                        paramDetalleCompra.Value = dtDetalleCompra;
                        cmd.Parameters.Add(paramDetalleCompra);

                        // Abrir conexión
                        con.Open();

                        // Ejecutar el procedimiento almacenado
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Verificar si se registró correctamente
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Compra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

