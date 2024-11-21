using Constants;
using UnityEngine;

public class PlayerManager : SingletonDontDestroy<PlayerManager>
{
    private Player _player;

    public void Init(DataManager dataManager)
    {
        _player = Resources.Load<Player>(Utils.Str.Clear().Append(Path.CharacterPath).Append("Player").ToString());

        _player = Instantiate(_player);
        _player.Init(dataManager.ShipData.Get(100000));
    }
}
