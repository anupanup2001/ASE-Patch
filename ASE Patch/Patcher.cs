using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ASE_Patch
{
    class Patcher
    {
        private bool m_bPatched = false;
        private bool m_bCorrectFile = false;
        private string m_strSourceFile;
        private byte[] m_strSearchBinaryString;
        private byte[] m_strReplaceBinaryString;
        int m_nOffset;

        public Patcher(string strSourceFile, byte[] strSearchBinaryString, byte[] strReplaceBinaryString, int nOffset)
        {
            m_strSourceFile = strSourceFile;
            m_strSearchBinaryString = strSearchBinaryString;
            m_strReplaceBinaryString = strReplaceBinaryString;
            m_nOffset = nOffset;
        }

        public bool IsPatched()
        {
            return m_bPatched;
        }

        public bool IsCorrectFile()
        {
            return m_bCorrectFile;
        }

        public void InitializeFlags()
        {
            try
            {
                using (FileStream fs = new FileStream(m_strSourceFile, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader r = new BinaryReader(fs))
                    {
                        int l_nNumOfBytesToRead = m_strSearchBinaryString.Length;
                        byte[] l_arrReadBytes = new byte[l_nNumOfBytesToRead];
                        fs.Seek(m_nOffset, SeekOrigin.Begin);
                        l_arrReadBytes = r.ReadBytes(l_nNumOfBytesToRead);

                        if (Enumerable.SequenceEqual(l_arrReadBytes, m_strSearchBinaryString))
                        {
                            m_bCorrectFile = true;
                            m_bPatched = false;
                        }
                        else if (Enumerable.SequenceEqual(l_arrReadBytes, m_strReplaceBinaryString))
                        {
                            m_bCorrectFile = true;
                            m_bPatched = false;
                        }
                        else
                        {
                            m_bCorrectFile = false;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception found during initialize: " + e.Message);
            }
        }

        public bool Patch()
        {
            try
            {
                using (FileStream fs = new FileStream(m_strSourceFile, FileMode.Open, FileAccess.ReadWrite))
                {
                    //If control reaches here, File exists and ReadBytes is equal to search string... Moving ahead to patch

                    using (BinaryWriter w = new BinaryWriter(fs))
                    {
                        fs.Seek(m_nOffset, SeekOrigin.Begin);
                        w.Write(m_strReplaceBinaryString);
                        //MessageBox.Show("File patched successfully!!");
                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
