public class Solution {
    public IList<int> GetRow(int rowIndex) {


  var list = new List<IList<int>>();
  list.Add(new List<int>() { 1});
  if (rowIndex == 0)
        return list[0];

 

  for (int i = 1; i <= rowIndex; i++)
  {
      List<int> previous = (List<int>)list[i - 1];

            //left corner always 1
            List<int> added = new List<int> { 1 };

            for (int j = 1; j < previous.Count; j++)
            {
                //grabbing two from the top
                added.Add(previous[j - 1] + previous[j]);
            }

            //right corner always 1
            added.Add(1);
            list.Add(added); ;
        }

        return list[rowIndex];
    }
}