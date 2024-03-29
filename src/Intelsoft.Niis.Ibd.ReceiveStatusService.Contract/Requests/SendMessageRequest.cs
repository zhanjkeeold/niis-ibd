﻿using System.ServiceModel;
using System.Xml.Linq;

namespace Intelsoft.Niis.Ibd.ReceiveStatusService.Contract.Requests
{
    /// <summary>
    ///     Сообщение от ИБД.
    /// </summary>
    [MessageContract(
        IsWrapped = true,
        WrapperName = Globals.SendMessage,
        WrapperNamespace = Globals.ServiceContractNamespace)]
    public class SendMessageRequest
    {
        /// <summary>
        ///     Заголовок с подписью.
        /// </summary>
        [MessageHeader(
            MustUnderstand = true,
            Namespace = Globals.SecurityHeaderNamespace)]
        public XElement Security { get; set; }

        /// <summary>
        ///     Запрос от ИБД.
        /// </summary>
        [MessageBodyMember(
            Name = "request",
            Namespace = Globals.Empty)]
        public Request Request { get; set; }
    }
}