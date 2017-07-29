using System;
using Xunit;
using COC;

/*Test 1:
Given: 1 cannon, 1 barbarian
When: Army attacks the village
Then: Defense wins.
Explanation
Cannon kills 1 Barbarian per 5 shots (45/10). Barbarian destroys 1 Cannon per 49 hits (390/8).


Test 2:
Given: 1 cannon, 10 barbarians
When: Army attacks the village
Then: Attack wins.
Explanation
Cannon will need 50 shots to destroy 10 Barbarians. Barbarians will need 49 shots. */


namespace coc.test
{
    public class CocTest
    {
        [Fact]
        public void Defence_should_win_when_there_is_one_canon_and_one_barbarian()
        {
            var clash = new Clash();
            clash.NoOfCanons = 1;
            clash.NoOfBarabarians = 1;
            
            var winner = clash.FinishBattle();

            Assert.Equal("Defence", winner);            
        }

        [Fact]
        public void Attack_should_win_when_there_is_one_canon_and_ten_barbarian()
        {
            var clash = new Clash();
            clash.NoOfCanons = 1;
            clash.NoOfBarabarians = 10;
            
            var winner = clash.FinishBattle();

            Assert.Equal("Attack", winner); 
        }

    }
}
