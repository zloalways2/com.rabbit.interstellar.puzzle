using UnityEngine;
using ZeroSDK.Utility.Singleton;

namespace _project.Scripts
{
    public sealed class qewergtrhtyujmjk : nbgvdfcsx<qewergtrhtyujmjk>
    {
        [SerializeField] private AudioSource musicSource;
        [SerializeField] private AudioSource pressSource;
        [SerializeField] private AudioSource takePuzzleSource;
        [SerializeField] private AudioSource puzzleMatchSource;
        [SerializeField] private AudioSource winSource;

        public override void Awake()
        {
            base.Awake();
            mnhgfbdfvsc(PlayerPrefs.GetInt(dewfrgtyhngj.desfrdgtfbghn, 1) == 1 ? 0.5f : 0);
            jhrtgerfsd(PlayerPrefs.GetInt(dewfrgtyhngj.wdefrgthgnj, 1) == 1 ? 0.5f : 0);
        }

        public void mnhgfbdfvsc(float v)
        {
            musicSource.volume = v;
        }

        public void jhrtgerfsd(float v)
        {
            pressSource.volume = v;
            takePuzzleSource.volume = v;
            puzzleMatchSource.volume = v;
            winSource.volume = v;
        }

        public override void OnDestroy()
        {
            PlayerPrefs.SetInt(dewfrgtyhngj.desfrdgtfbghn, musicSource.volume > 0 ? 1 : 0);
            PlayerPrefs.SetInt(dewfrgtyhngj.wdefrgthgnj, pressSource.volume > 0 ? 1 : 0);

            PlayerPrefs.Save();
        }

        public void tynrtbervsc() => pressSource.Play();
        public void hjmghnfbvdcs() => takePuzzleSource.Play();
        public void jghgfbdvscxa() => winSource.Play();
        public void jhgbfvdc() => puzzleMatchSource.Play();
    }
}