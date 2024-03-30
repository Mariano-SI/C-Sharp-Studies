using System;

namespace Cap09_EnumeracoesEComposicao.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
