# Unit Of Work With Generic Repository Pattern Demonstration
#### 1.  All the logic is separated and from API controllers as well as from the domain.
#### 2. Used a generic typed repository where all the common typed methods are there.
#### 3. So that class is inherited by all needed repositories where other complex methods can be written and acquired from the database.
#### 4. Also, one UnitOfWork class was implemented, which holds all the required repositories.
#### 5. So now from the controller, we only need to get what we need by calling this unit work via its interface.
