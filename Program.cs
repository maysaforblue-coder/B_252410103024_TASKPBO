using System;
using System.Collections.Generic;

namespace tugas
{
    class item
    {
        public string judul;
        public int tahun;
        public item(string judul, int tahun)
        {
            this.judul = judul;
            this.tahun = tahun;
        }

        public virtual void Deskripsi()
        {
            Console.WriteLine("Judul : " + judul + "  tahun : " + tahun);
        }
        public void infoItem()
        {
            Console.WriteLine("judul : " + judul + "  tahun : " + tahun);
        }
    }

    class buku : item
    {
        public string penulis;
        public buku(string judul, int tahun, string penulis) : base(judul, tahun)
        {
            this.penulis = penulis;
        }
        public void cekPenulis()
        {
            Console.WriteLine(" Penulis : " + penulis);
        }
        public override void Deskripsi()
        {
            Console.WriteLine("Judul : " + judul + "  tahun : " + tahun + "  penulis: " + penulis);
        }
    }

    class majalah : item
    {
        public int edisi;
        public majalah(string judul, int tahun, int edisi) : base(judul, tahun)
        {
            this.edisi = edisi;
        }

        public void infoEdisi()
        {
            Console.WriteLine("Edisi : " + edisi);
        }
        public override void Deskripsi()
        {
            Console.WriteLine("Judul : " + judul + "  tahun : " + tahun + "  edisi :" + edisi);
        }
    }

    class novel : buku
    {
        public novel(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }
        public void bacaSinopsis()
        {
            Console.WriteLine("sinopsis dari " + judul + " Salva sering disapa Ava...");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("Judul : " + judul + "  tahun : " + tahun + "  penulis : " + penulis);
        }

    }

    class komik : buku
    {
        public komik(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }
        public void tampilkanIlustrasi()
        {
            Console.WriteLine("Menampilkan ilustrasi dari komik berjudul " + judul);
        }
        public override void Deskripsi()
        {
            Console.WriteLine("Judul : " + judul + "  tahun : " + tahun + "  penulis : " + penulis);
        }
    }

    class majalahAnak : majalah
    {
        public majalahAnak(string judul, int tahun, int edisi) : base(judul, tahun, edisi)
        {
        }

        public void kategoriAnak()
        {
            Console.WriteLine("Majalah untuk Anak-anak usia 6 tahun keatas.");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("Judul : " + judul + "  tahun : " + tahun + "  edisi ; " + edisi);
        }

    }
    class majalahTeknologi : majalah
    {
        public majalahTeknologi(string judul, int tahun, int edisi) : base(judul, tahun, edisi)
        {
        }
        public void topikTeknologi()
        {
            Console.WriteLine("Majalah dengan topik seputar Teknologi.");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("Judul : " + judul + "  tahun : " + tahun + "  edisi : " + edisi);
        }

    }

    class Perpustakaan
    {
        private List<item> daftarItem;

        public Perpustakaan()
        {
            daftarItem = new List<item>();
        }

        public void TambahItem(item Item)
        {
            daftarItem.Add(Item);
            Console.WriteLine($"-> Sukses menambahkan '{Item.judul}' ke perpustakaan.");
        }

        public void DaftarItem()
        {
            Console.WriteLine("\n=== DAFTAR KOLEKSI PERPUSTAKAAN ===");
            foreach (item Item in daftarItem)
            {
                Item.Deskripsi();
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Perpustakaan p = new Perpustakaan();
            novel novel1 = new novel("Di Tanah Lada", 2024, "Ziggy Z.");
            komik komik1 = new komik("Detective Conan", 1996, "Gosho Aoyama");
            majalah majalah1 = new majalah("Tempo", 1971, 2000);
            majalahAnak majalahanak1 = new majalahAnak("Majalah Bobo", 2014, 23);
            majalahTeknologi majalahTeknologi1 = new majalahTeknologi("InfoKomputer", 2019, 2019);

            p.TambahItem(novel1);
            p.TambahItem(komik1);
            p.TambahItem(majalahanak1);
            p.TambahItem(majalahTeknologi1);

            p.DaftarItem();

            Console.WriteLine();
            Console.WriteLine("soal 1");
            novel1.Deskripsi();
            majalah1.Deskripsi();
            Console.WriteLine();

            Console.WriteLine("soal 2");
            novel1.bacaSinopsis();
            Console.WriteLine();

            Console.WriteLine("soal 3");
            novel1.Deskripsi();
            Console.WriteLine();

            Console.WriteLine("soal 4");
            majalahTeknologi1.topikTeknologi();
            Console.WriteLine();

            Console.WriteLine("soal 5");
            item item1 = new komik("Si Juki", 2010, "Faza Ibnu U. S.");
            item1.Deskripsi();
            Console.WriteLine();

        }
    }
}



