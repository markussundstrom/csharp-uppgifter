using System.Collections;

namespace _2_27_1
{
    public class Stack {
        private List<Object> _objectlist = new List<Object>();

        public void Push(Object obj) {
            if (obj == null) {
                throw new InvalidOperationException("Can't push null to stack");
            } else {
                _objectlist.Add(obj);
            }
        }

        public Object Pop() {
            if (this._objectlist.Count == 0) {
                throw new InvalidOperationException("Can't pop empty list");
            } else {
                Object last = _objectlist[_objectlist.Count - 1];
                _objectlist.RemoveAt(_objectlist.Count - 1);
                return last;
            }
        }

        public void Clear() {
            _objectlist.Clear();
        }
    }
}
