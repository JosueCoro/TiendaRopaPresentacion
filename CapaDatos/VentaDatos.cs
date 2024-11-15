using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class VentaDatos
    {
        private string conexion = new conexion_bd().GetCadenaConexion();

        private conexion_bd conexionbd = new conexion_bd();

        /* -- Creación del tipo de tabla para el detalle de venta
            CREATE TYPE DetalleVentaTipo AS TABLE (
                IdProducto INT,
                PrecioVenta DECIMAL(10, 2),
                Cantidad INT
            );
            GO
            CREATE PROCEDURE RegistrarVenta
                @IdUsuario INT,
                @IdCliente INT,
                @MontoPago DECIMAL(30, 3),
                @MontoCambio DECIMAL(30, 3),
                @MontoTotal DECIMAL(30, 3),
                @DetalleVenta DetalleVentaTipo READONLY
            AS
            BEGIN
                -- Iniciar una transacción
                BEGIN TRANSACTION;

                BEGIN TRY
                    -- Paso 1: Insertar registro en la tabla VENTA
                    DECLARE @IdVenta INT;

                    INSERT INTO VENTA (IdUsuario, IdCliente, MontoPago, MontoCambio, MontoTotal, FechaRegistro)
                    VALUES (@IdUsuario, @IdCliente, @MontoPago, @MontoCambio, @MontoTotal, GETDATE());

                    -- Obtener el IdVenta recién creado
                    SET @IdVenta = SCOPE_IDENTITY();

                    -- Paso 2: Insertar detalles de venta en DETALLE_VENTA
                    INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, FechaRegistro)
                    SELECT 
                        @IdVenta, 
                        IdProducto, 
                        PrecioVenta, 
                        Cantidad, 
                        GETDATE()
                    FROM @DetalleVenta;

                    -- Paso 3: Actualizar el stock de cada producto en la tabla PRODUCTO
                    UPDATE P
                    SET P.Stock = P.Stock - D.Cantidad
                    FROM PRODUCTO P
                    INNER JOIN @DetalleVenta D ON P.IdProducto = D.IdProducto;

                    -- Confirmar transacción
                    COMMIT TRANSACTION;

                    PRINT 'Venta registrada exitosamente con IdVenta: ' + CAST(@IdVenta AS VARCHAR);

                END TRY
                BEGIN CATCH
                    -- Revertir la transacción en caso de error
                    ROLLBACK TRANSACTION;
                    PRINT 'Error al registrar la venta: ' + ERROR_MESSAGE();
                END CATCH
            END;
            GO*/

        // Método para registrar una venta
        public void RegistrarVenta(VentaClass venta)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    using (SqlCommand cmd = new SqlCommand("RegistrarVenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros principales de la venta
                        cmd.Parameters.AddWithValue("@IdUsuario", venta.IdUsuario);
                        cmd.Parameters.AddWithValue("@IdCliente", venta.IdCliente);
                        cmd.Parameters.AddWithValue("@MontoPago", venta.MontoPago);
                        cmd.Parameters.AddWithValue("@MontoCambio", venta.MontoCambio);
                        cmd.Parameters.AddWithValue("@MontoTotal", venta.MontoTotal);

                        // Crear la tabla de detalles de venta
                        DataTable dtDetalleVenta = new DataTable();
                        dtDetalleVenta.Columns.Add("IdProducto", typeof(int));
                        dtDetalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
                        dtDetalleVenta.Columns.Add("Cantidad", typeof(int));

                        // Agregar los detalles de la venta a la tabla
                        foreach (VentaClass.DetalleVenta detalle in venta.Detalles)
                        {
                            dtDetalleVenta.Rows.Add(detalle.IdProducto, detalle.PrecioVenta, detalle.Cantidad);
                        }

                        // Parámetro para el detalle de venta
                        SqlParameter parametroDetalle = new SqlParameter("@DetalleVenta", SqlDbType.Structured);
                        parametroDetalle.Value = dtDetalleVenta;
                        cmd.Parameters.Add(parametroDetalle);

                        // Ejecutar el procedimiento almacenado
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Venta registrada correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
