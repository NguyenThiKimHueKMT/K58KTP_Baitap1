using System;
using System.Collections.Generic;
using System.Text;

namespace Tholibrary
{
    public class PoetryMaker
    {
        public string InputText { get; set; }
        public string Poem { get; private set; }

        // Từ điển cơ bản
        private List<string> DanhTu = new List<string> { "hoa", "trăng", "mây", "nắng", "gió", "mùa", "đêm", "ngày", "sông", "núi", "biển", "mưa", "lá", "chim", "bướm" };
        private List<string> TinhTu = new List<string> { "đẹp", "buồn", "xanh", "vàng", "rực rỡ", "nhỏ bé", "lung linh", "tươi", "lặng lẽ", "mênh mông", "ngọt ngào", "ấm áp", "hiền hòa" };
        private List<string> DongTu = new List<string> { "bay", "trôi", "nhớ", "thương", "chờ", "đợi", "nở", "rụng", "cười", "khóc", "thắp", "đưa", "đi", "về" };

        // Mẫu thơ
        private List<string> Templates = new List<string>
        {
            "Trên trời {danh từ} {động từ} {tính từ},",
            "{danh từ} rơi xuống giữa chiều {tính từ},",
            "Một vầng {danh từ} khẽ {động từ},",
            "Lòng ai {động từ} những nỗi {tính từ}.",

            "{danh từ} nở giữa mùa {tính từ},",
            "Hồn ai {động từ} trong chiều buồn,",
            "Tiếng {danh từ} vọng khắp trời xa,",
            "Người {động từ} mãi nhớ tình ta {tính từ}.",

            "Chiều buông {danh từ} {tính từ} rụng,",
            "Ánh {danh từ} {động từ} phủ lối đi,",
            "Một khúc {danh từ} nghe {tính từ},",
            "Gợi bao {danh từ} nhớ xuân thì.",

            "Sóng {động từ} trên biển {tính từ},",
            "Cánh {danh từ} bay giữa trời xanh,",
            "{danh từ} nghiêng nghiêng bên hiên nhỏ,",
            "Lòng {tính từ} theo bước chân anh.",

            "Bóng {danh từ} trải dài trong đêm,",
            "Tiếng {danh từ} vọng mãi chẳng quên,",
            "Một khúc tình ngân {tính từ},",
            "Người {động từ} mãi nhớ tên."
        };

        public string MakePoem()
        {
            if (string.IsNullOrEmpty(InputText))
            {
                Poem = "Chưa có văn bản để làm thơ!";
                return Poem;
            }

            // Chia từ từ input
            string[] words = InputText.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // List riêng biệt cho từng loại
            List<string> danhTuList = new List<string>();
            List<string> tinhTuList = new List<string>();
            List<string> dongTuList = new List<string>();

            // Duyệt từ input và phân loại
            foreach (string rawWord in words)
            {
                string w = rawWord.ToLower();

                if (!danhTuList.Contains(w) && DanhTu.Contains(w))
                    danhTuList.Add(w);

                if (!tinhTuList.Contains(w) && TinhTu.Contains(w))
                    tinhTuList.Add(w);

                if (!dongTuList.Contains(w) && DongTu.Contains(w))
                    dongTuList.Add(w);
            }

            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            // Sinh 4 câu
            for (int i = 0; i < 4; i++)
            {
                string template = Templates[rnd.Next(Templates.Count)];

                string line = template
                    .Replace("{danh từ}", GetWord(rnd, danhTuList, DanhTu))
                    .Replace("{tính từ}", GetWord(rnd, tinhTuList, TinhTu))
                    .Replace("{động từ}", GetWord(rnd, dongTuList, DongTu));

                sb.AppendLine(line);
            }

            Poem = sb.ToString().Trim();
            return Poem;
        }

        private string GetWord(Random rnd, List<string> input, List<string> backup)
        {
            if (input.Count > 0)
                return input[rnd.Next(input.Count)];
            else
                return backup[rnd.Next(backup.Count)];
        }
    }
}
