//*****************************************************************************
//** 44. Find Smallest Letter Greater Than Target                   leetcode **
//*****************************************************************************
//** Through sorted ranks the letters stand, in quiet ordered line,          **
//** We hunt the one that beats our mark, just barely, just in time.         **
//** If none step forth beyond the goal, we circle back to start,            **
//** A faster path, a clever loop, where logic plays its part.               **
//*****************************************************************************

char nextGreatestLetter(char* letters, int lettersSize, char target) {
    int left = 0;
    int right = lettersSize - 1;
    char retval = letters[0];

    while(left <= right)
    {
        int mid = left + ((right - left) >> 1);

        if(letters[mid] > target)
        {
            retval = letters[mid];
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }
    }

    return retval;
}