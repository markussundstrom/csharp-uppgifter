namespace _2_16_1
{
    public class StopWatch {
        
        private DateTime? _startTime = null;
        private DateTime? _stopTime = null;

        
        public void Start() {
            if (_startTime.HasValue && !_stopTime.HasValue) {
                throw new InvalidOperationException("Attempt to call start on already running stopwatch");
            } else {
                _startTime = DateTime.Now;
                _stopTime = null;
            }
        }

        public void Stop() {
            if (_stopTime.HasValue || !_startTime.HasValue) {
                throw new InvalidOperationException("Attempt to call stop on a stopped stopwatch");
            } else {
                _stopTime = DateTime.Now;
            }
        }

        public TimeSpan ShowTime() {
            if (!_startTime.HasValue || !_stopTime.HasValue) {
                throw new InvalidOperationException("Attempt to show time, but no time has been recorded");
            } else {
                return _stopTime.Value - _startTime.Value;
            }
        }


    
    }
}