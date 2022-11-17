namespace _21810203.Entities
{
    public struct PhieuNhap
    {
        public int MaPhieu;
        public DateTime date;
        public List<ChiTietPhieuNhap> chiTietPhieuNhap;
    }
    public struct ChiTietPhieuNhap
    {
        public int stt;
        public string ItemName;
        public int SoLuong;
    }
}
