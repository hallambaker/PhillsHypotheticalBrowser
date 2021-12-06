#region // Copyright - MIT License
//  © 2021 by Phill Hallam-Baker
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
#endregion

namespace HypotheticalBrowser;

public class History {

    public List<HistoryTab> Tabs { get; } = new List<HistoryTab>();

    public List<HistoryEntry> Entries { get; } = new List<HistoryEntry>();


    public HistoryTab CreateTab() {
        var tab = new HistoryTab(this);

        lock (this) {
            Tabs.Add(tab);
            }

        return tab;
        }

    }


public class HistoryTab {

    History History { get; }

    public List<HistoryEntry> Entries { get; } = new List<HistoryEntry>();

    internal HistoryTab(History history) {
        History = history;
        }

    public HistoryEntry AddEntry (
        string Uri) {
        var entry = new HistoryEntry(this, Uri);

        lock (History) {
            Entries.Add(entry);
            History.Entries.Add(entry);
            }

        return entry;
        }

    }

public class HistoryEntry {

    HistoryTab HistoryTab { get; }



    internal HistoryEntry(
                HistoryTab historyTag, 
                string Uri ) {
        HistoryTab = historyTag;
        }


    }
