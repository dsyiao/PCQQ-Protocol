namespace QQ.Framework.Packets.Send.Data
{
    public class Send_0X0195 : SendPacket
    {
        /// <summary>
        /// 群分组信息查询
        /// </summary>
        /// <param name="User"></param>
        public Send_0X0195(QQUser User)
            : base(User)
        {
            Sequence = GetNextSeq();
            SecretKey = User.TXProtocol.SessionKey;
            Command = QQCommand.Data0X0195;
        }

        protected override void PutHeader()
        {
            base.PutHeader();
            Writer.Write(User.QQPacketFixver);
        }

        /// <summary>
        ///     初始化包体
        /// </summary>
        protected override void PutBody()
        {
            BodyWriter.Write(new byte[] { 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 });
        }
    }
}