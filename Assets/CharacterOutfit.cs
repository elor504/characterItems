using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOutfit : MonoBehaviour
{
    public SpriteRenderer hatSprite;
    public SpriteRenderer shirtSprite;
    public SpriteRenderer pantsSprite;
    public SpriteRenderer shoesSprite;
    public SpriteRenderer weaponSprite;

    public void WearOnCharacter(ClothType _clothType,Sprite _clothSprite)
	{
		switch (_clothType)
		{
			case ClothType.helmet:
				hatSprite.sprite = _clothSprite;
				break;
			case ClothType.shirt:
				shirtSprite.sprite = _clothSprite;
				break;
			case ClothType.pants:
				pantsSprite.sprite = _clothSprite;
				break;
			case ClothType.shoes:
				shoesSprite.sprite = _clothSprite;
				break;
			case ClothType.weapon:
				weaponSprite.sprite = _clothSprite;
				break;
			default:
				break;
		}
	}
}
public enum ClothType
{
    helmet,
    shirt,
    pants,
    shoes,
    weapon
}