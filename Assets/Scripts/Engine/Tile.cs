﻿using UnityEngine;
using UnityEngine.UI;

namespace MatchThreeEngine
{
    public sealed class Tile : MonoBehaviour
    {
        public int x;
        public int y;
        public Image icon;
        public Button button;
        private TileType _type;

        public TileType Type
        {
            get => _type;

            set
            {
                if (_type == value) return;

                _type = value;

                icon.sprite = _type.sprite;
            }
        }

        // Свойство для получения данных плитки
        public TileDataContainer Data => new TileDataContainer(x, y, _type.id);

        // Метод для инициализации плитки
        public void Initialize(int x, int y, TileType type)
        {
            this.x = x;
            this.y = y;
            Type = type;

            // Подписка на событие нажатия кнопки
            button.onClick.AddListener(OnTileClicked);
        }

        // Обработчик события нажатия на плитку
        private void OnTileClicked()
        {
            // Логика обработки клика по плитке
            Debug.Log($"Tile clicked at ({x}, {y}) with type {_type.id}");
        }
    }
}