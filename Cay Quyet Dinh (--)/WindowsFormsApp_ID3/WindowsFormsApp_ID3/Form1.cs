using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_ID3.mdoels;


namespace WindowsFormsApp_ID3
{
    public partial class Form1 : Form
    {
        Model1 context = new Model1();
        public static  Dictionary<string, double> max = new Dictionary<string, double>();
         public static Dictionary<string, double> max2 = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaiDat();
            Vi();
            max.Clear();
            Block();
            Display();
            
        }

        public void Block()
        {

            btnChonCayPhanHoach.Enabled = false;
            btnTinhToan2.Visible = false;
        }

        public void UnBlock()
        {
            txtMax.Text = "0";         
            btnChonCayPhanHoach.Enabled = true;

        }

        public void Vi()
        {
            btnChonCayPhanHoach.Visible = true;
            button1.Visible = false;
        }

        public void UnVi()
        {
            
            btnTinhToan.Visible = false;
            btnTinhToan2.Visible = true;
            button1.Visible = true;
            btnChonCayPhanHoach.Visible = false;
        }

      

        public void CaiDat()
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Display()
        {
            List<EntropyDTO> list = new List<EntropyDTO>();
            list = context.Entropies.Select(x => new EntropyDTO
            {
                id = x.Id,
                hinhDang = x.HinhDang,
                chieuCao = x.ChieuCao,
                gioiTinh = x.GioiTinh,
                ketQua = x.KetQua
            }).ToList();
            dgv.DataSource = list;

        }

        public double Info(List<Entropy> entropies)
        {
            int n = 0, t = 0;
            double  entropy = 0;
            List<Entropy> list = entropies;
            foreach (var item in entropies)
            {
                if(item.KetQua == list[0].KetQua)
                {
                    t += 1;
                }
                else
                {
                    n += 1;
                }
            }

            if (t == 0 || n == 0)
            {
                return 0;
            }
            else if (t == n)
            {
                return 1;
            }
            else
            {
                entropy = (double) 0 - ((((double)t / (t + n)) * ( Math.Log((double)t / (t + n),2)) + ((double)n / (t + n)) *(Math.Log((double)n / (t + n), 2))));
                txtInfo.Text = entropy.ToString();
                return entropy;
            }        
        }

        public double entropy(List<Entropy> entropies , List<Entropy> atttribute)
        {
            int n = 0, t = 0;
            double entropy = 0;
            List<Entropy> list = entropies;
            foreach (var i in entropies)
            {
                foreach (var j in atttribute)
                {
                    if (i == j)
                    {
                        if (j.KetQua == list[0].KetQua)
                        {
                            t += 1;
                            
                        }
                        else
                        {
                            n += 1;
  
                        }
                    }
                }
            }
            if (t == 0 || n == 0)
            {
                return 0;
            }
            else if (t == n)
            {
                return 1;
            }
            else
            {
                entropy = (double) 0 - ((((double)t / (t + n)) * (Math.Log((double)t / (t + n), 2)) + ((double)n / (t + n)) * (Math.Log((double)n / (t + n), 2))));
                return entropy;
            }

        }
   
        public double Info_Gain(List<Entropy> entropies, List<Entropy> attribute)
         {
             double infoGain = 0;
             infoGain =  (double)attribute.Count() / entropies.Count() * entropy(entropies, attribute);         
             return infoGain;
         }

         private void btnPhanHoach_Click(object sender, EventArgs e)
         {           
            Gain();
         }

        public double Gain()
        { 
            double gain = 0;
            try
            {
                List<Entropy> entropies = context.Entropies.ToList();
                if (rdoHinhDang.Checked == true)
                {
                    
                    UnBlock();
                    List<Entropy> attributeTo = context.Entropies.Where(x => x.HinhDang.ToLower().Contains("to")).ToList();
                    List<Entropy> attributeNho = context.Entropies.Where(x => x.HinhDang.ToLower().Contains("nhỏ")).ToList();
                    double to = Info_Gain(entropies, attributeTo);
                    double nho = Info_Gain(entropies, attributeNho);
                    if (to <= 0 && nho <= 0)
                    {
                        txtTinhGain.Text = gain.ToString();
                        return gain;
                    }
                    else
                    {
                        gain = (double)Info(entropies) - (to + nho);
                        max.Add("Hình dáng", gain);
                        txtTinhGain.Text = gain.ToString();
                        return gain;
                    }
                    
                }
                else if (rdoChieuCao.Checked == true)
                {
                    UnBlock();
                    List<Entropy> attributeThap = context.Entropies.Where(x => x.ChieuCao.ToLower().Contains("thấp")).ToList();
                    List<Entropy> attributeTB = context.Entropies.Where(x => x.ChieuCao.ToLower().Contains("trung bình")).ToList();
                    List<Entropy> attributeCao = context.Entropies.Where(x => x.ChieuCao.ToLower().Contains("Cao")).ToList();
                    double thap = Info_Gain(entropies, attributeThap);
                    double tb = Info_Gain(entropies, attributeTB);
                    double cao = Info_Gain(entropies, attributeCao);
                    if (thap <= 0 && tb <= 0 && cao <= 0)
                    {
                        txtTinhGain.Text = gain.ToString();
                        return gain;
                    }
                    else
                    {
                        gain = (double)Info(entropies) - (thap + tb + cao);
                        max.Add("Chiều cao", gain);
                        txtTinhGain.Text = gain.ToString();
                        return gain;
                    }                  
                }
                else if (rdoGioiTinh.Checked == true)
                {
                    UnBlock();
                    List<Entropy> attributeNam = context.Entropies.Where(x => x.GioiTinh.ToLower().Contains("nam")).ToList();
                    List<Entropy> attributeNu = context.Entropies.Where(x => x.GioiTinh.ToLower().Contains("nữ")).ToList();
                    double nam = Info_Gain(entropies, attributeNam);
                    double nu = Info_Gain(entropies, attributeNu);
                    gain = (double)Info(entropies) - (nam + nu);
                    if (nam <= 0 && nu <= 0)
                    {
                        txtTinhGain.Text = gain.ToString();
                        return gain;
                    }
                    else
                    {
                        max.Add("Giới tính", gain);
                        txtTinhGain.Text = gain.ToString();
                        return gain;
                    }                  
                }
                return gain;
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           return gain;
        }

        public double Info_max()
        {
           
            double giaTri = 0;
            foreach (KeyValuePair<string, double> i in max)
            {
                if(giaTri < i.Value)
                {
                    giaTri = i.Value;
                   
                }             
            }          
            return giaTri;
        }

        public double min()
        {
            double giaTri = 0;
            foreach (KeyValuePair<string, double> i in max)
            {
                if (giaTri > i.Value)
                {
                    giaTri = i.Value;

                }
            }
            return giaTri;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            rdoChieuCao.Enabled = false;
            UnVi();
            txtMax.Text = Info_max().ToString();
            List<EntropyDTO> list = new List<EntropyDTO>();
            List<double> gains = new List<double>() ;            
             foreach (KeyValuePair<string, double> i in max)
             {
                 if (i.Value.Equals(Info_max()))
                 {
                    MessageBox.Show("Chọn " +"'" +i.Key+"'" + " làm thuộc tính phân hoặch");                  
                     if (i.Key.Contains("Chiều cao"))
                     {
                        treeView1.Nodes.Add(i.Key);
                        treeView1.Nodes[0].Nodes.Add("thấp");
                        treeView1.Nodes[0].Nodes.Add("trung bình");
                        treeView1.Nodes[0].Nodes.Add("cao");
                     }
                     else if(i.Key.Contains("Hình dáng"))
                     {
                        treeView1.Nodes.Add(i.Key);
                        treeView1.Nodes[0].Nodes.Add("to");
                        treeView1.Nodes[0].Nodes.Add("nhỏ");
                     }

                     else if(i.Key.Contains("Giới tính"))
                     {
                        treeView1.Nodes[0].Nodes.Add("nam");
                        treeView1.Nodes[0].Nodes.Add("nữ");
                     }
                     else
                     {
                        treeView1.Nodes[0].Nodes.Add("Trống");
                     }
                    
                 }
             }
            List<Entropy> entropies = context.Entropies.Where(x => x.ChieuCao != "thấp" && x.ChieuCao != "cao").ToList();
            dgv.DataSource = entropies;
        }

        public double max_info()
        {
            double giaTri = 0;
            foreach (KeyValuePair<string, double> i in max2)
            {
                if (giaTri < i.Value)
                {
                    giaTri = i.Value;
                }
            }
            return giaTri;
        }
      
        private double Gain2()
        {
           
            double gain = 0;
            try
            {
                List<Entropy> entropies2 = context.Entropies.ToList();
                List<Entropy> entropies = context.Entropies.Where(x=> x.ChieuCao != "thấp" && x.ChieuCao != "cao").ToList();
                if (rdoHinhDang.Checked == true)
                {
                    UnBlock();
                    List<Entropy> attributeTo = context.Entropies.Where(x => x.HinhDang.ToLower().Contains("to") && x.ChieuCao != "thấp" && x.ChieuCao != "cao").ToList();
                    List<Entropy> attributeNho = context.Entropies.Where(x => x.HinhDang.ToLower().Contains("nhỏ") && x.ChieuCao != "thấp" && x.ChieuCao != "cao").ToList();
                    double to =  Info_Gain(entropies, attributeTo);
                    double nho = Info_Gain(entropies, attributeNho);
                    gain =  Info(entropies2) - (to + nho);
                    max2.Add("Hình Dáng", gain);
                    txtTinhGain.Text = gain.ToString();
                    return gain;
                                       
                }
                
                
                else if (rdoGioiTinh.Checked == true)
                {
                    UnBlock();
                    List<Entropy> attributeNam = context.Entropies.Where(x => x.GioiTinh.ToLower().Contains("nam") && x.ChieuCao != "thấp" && x.ChieuCao != "cao").ToList();
                    List<Entropy> attributeNu = context.Entropies.Where(x => x.GioiTinh.ToLower().Contains("nữ") && x.ChieuCao != "thấp" && x.ChieuCao != "cao").ToList();
                    double nam = Info_Gain(entropies, attributeNam);
                    double nu = Info_Gain(entropies, attributeNu);
                    gain = (double)Info(entropies2) - (nam + nu);
                    max2.Add("Giới tính", gain);
                    txtTinhGain.Text = gain.ToString();
                    return gain;
                    
                }
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gain;
        }
       
        private void btnTinhToan2_Click(object sender, EventArgs e)
        {
            Gain2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnVi();
            txtMax.Text = max_info().ToString();
            List<EntropyDTO> list = new List<EntropyDTO>();
            List<double> gains = new List<double>();
            foreach (KeyValuePair<string, double> i in max2)
            {
                if (i.Value.Equals(max_info()))
                {
                    MessageBox.Show("Chọn " + "'" + i.Key + "'" + " làm thuộc tính phân hoặch");
                   
                    if (i.Key.Contains("Hình Dáng"))
                    {
                        treeView1.Nodes[0].Nodes[1].Nodes.Add(i.Key);
                        treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("to");
                        treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("nhỏ");

                    }
                    else
                    {
                        treeView1.Nodes[0].Nodes[1].Nodes.Add(i.Key);
                        treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("nam");
                        treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("nữ");
                    }
                }
            }
            List<Entropy> entropies = context.Entropies.Where(x => x.ChieuCao != "thấp" && x.ChieuCao != "cao").ToList();
            dgv.DataSource = entropies;
        }
    }
}
