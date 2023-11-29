internal class WumpusGame
{
    private const int NUM_DIRECTIONS = 4;
    private enum Direction { North, East, South, West };
    private int _numRooms;
    private int _playerRoom;
    private int[][] _connections;

    public WumpusGame()
    {
        _numRooms = 10;
        _connections = new int[10][];

        for (int i = 0; i < _numRooms; i++)
        {
            _connections[i] = new int[NUM_DIRECTIONS];

            for (int j = 0; j < NUM_DIRECTIONS; j++)
            {
                _connections[i][j] = -1;
            }
        }

        _playerRoom = 0;
    }

    public void Connect(int room1, int room2, string direction)
    {
        if (room1 < _numRooms && room2 < _numRooms) 
        { 
            switch(direction)
            {
                case "N":
                    _connections[room1][(int)Direction.North] = room2;
                    _connections[room2][(int)Direction.South] = room1;
                    break;
                case "E":
                    _connections[room1][(int)Direction.East] = room2;
                    _connections[room2][(int)Direction.West] = room1;
                    break;
                case "S":
                    _connections[room1][(int)Direction.South] = room2;
                    _connections[room2][(int)Direction.North] = room1;
                    break;
                case "W":
                    _connections[room1][(int)Direction.West] = room2;
                    _connections[room2][(int)Direction.East] = room1;
                    break;
            }
        }
    }   

    public void SetPlayerRoom(int room)
    {
        if (room < _numRooms)
        { 
            _playerRoom = room;
        }
    }   

    public int GetPlayerRoom()
    {
        return _playerRoom;
    }

    public void North()
    {
        if (_connections[_playerRoom][(int)Direction.North] != -1)
        {
            _playerRoom = _connections[_playerRoom][(int)Direction.North];
        }
        else
        {
            throw new System.InvalidOperationException();
        }
    }

    public void East()
    {
        if (_connections[_playerRoom][(int)Direction.East] != -1)
        {
            _playerRoom = _connections[_playerRoom][(int)Direction.North];
        }
        else
        {
            throw new System.InvalidOperationException();
        }
    }

    public void South()
    {
        if (_connections[_playerRoom][(int)Direction.South] != -1)
        {
            _playerRoom = _connections[_playerRoom][(int)Direction.North];
        }
        else
        {
            throw new System.InvalidOperationException();
        }
    }
    public void West()
    {
        if (_connections[_playerRoom][(int)Direction.West] != -1)
        {
            _playerRoom = _connections[_playerRoom][(int)Direction.North];
        }
        else
        {
            throw new System.InvalidOperationException();
        }
    }
}
