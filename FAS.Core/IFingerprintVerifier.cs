namespace FAS.Core
{
    public interface IFingerprintVerifier : IFingerprintCapturer
    {
        bool Verify(byte[] checkSum);
    }
}
