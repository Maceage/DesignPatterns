using FacadePattern.Domain.Computer;

namespace FacadePattern.Domain
{
    public class ComputerFacade
    {
        private readonly Processor _processor;
        private readonly Memory _memory;
        private readonly HardDrive _hardDrive;

        public ComputerFacade()
        {
            _processor = new Processor();
            _memory = new Memory();
            _hardDrive = new HardDrive();
        }

        public void Start()
        {
            _processor.Start();
            _memory.Allocate();
            _hardDrive.Spin();
        }
    }
}