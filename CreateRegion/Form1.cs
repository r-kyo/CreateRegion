using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateRegion {
    public partial class Form1 : Form {
        private readonly String[] _scope = { "Public", "Protected", "Friend", "Private" };
        private readonly String[] _function = { "Function", "Sub" };
        private List<String> _convText = new List<String>();

        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// 実行ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteButton_Click(object sender, EventArgs e) {
            string[] delimiter = { "\r\n" };
            string[] lines = BaseText.Text.Split(delimiter, StringSplitOptions.None);
            FunctionInfo funcInfo = null;

            for (int i = 0; i < lines.Length - 1; i++) {
                string[] sentence = lines[i].Split(' ');
                
                // summaryタグが見つかった場合
                if (sentence.Contains("<summary>")) {
                    funcInfo = GetFuncInfo(lines, i);

                    if (funcInfo != null) {
                        // Regionの追加
                        if (RegionCheck.Checked) {
                            _convText.Add($"#Region \" {funcInfo.Name}".PadRight(39) + $"{funcInfo.Summary} \"");
                        }

                        AddCommentDecorator();
                    }
                }

                // コメント修飾文字の追加
                if (funcInfo != null && i == funcInfo.Row) {
                    AddCommentDecorator();
                }

                _convText.Add(lines[i]);

                // End Regionの追加
                if (sentence.Contains("End") &&
                    sentence.Any(s => _function.Contains(s)) &&
                    RegionCheck.Checked &&
                    funcInfo != null) {

                    _convText.Add("#End Region");
                    funcInfo = null;
                }
            }

            var form = new ResultForm(_convText);
            form.Show();
            _convText.Clear();
        }

        /// <summary>
        /// コメント修飾文字の追加
        /// </summary>
        private void AddCommentDecorator() {
            if (CommentCheck.Checked) {
                _convText.Add("''' -----------------------------------");
            }
        }

        /// <summary>
        /// 関数情報の取得
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="i"></param>
        private FunctionInfo GetFuncInfo(string[] lines, int i) {
            var funcInfo = new FunctionInfo();

            // 概要の取得
            funcInfo.Summary = lines[i + 1].Substring(lines[i + 1].IndexOf("''' ") + 4);

            for (int j = i + 1; j < lines.Length; j++) {
                string[] sentence = lines[j].Split(' ');

                // 関数の宣言行か
                if (!sentence.Any(s => _scope.Contains(s)) ||
                    !sentence.Any(s => _function.Contains(s))) {
                    
                    // 対象のブロックを過ぎた場合
                    if (sentence.Any(s => _scope.Contains(s))) {
                        break;
                    }
                    continue;
                }

                // 関数名取得
                funcInfo.Row = j;
                int funcIdx = sentence.Select((v, idx) => new { Value = v, Index = idx })
                                        .Where(hoge => _function.Contains(hoge.Value))
                                        .Select(hoge => hoge.Index).First();
                string tmp = sentence[funcIdx + 1];
                funcInfo.Name = tmp.Substring(0, tmp.IndexOf("("));

                break;
            }

            // 関数でない場合、null
            if (funcInfo.Name == null) {
                return null;
            }

            return funcInfo;
        }
    }
}
