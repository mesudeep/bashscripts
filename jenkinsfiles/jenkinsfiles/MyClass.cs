node {}{
    Stage(‘checkout’)
{
    Checkout sim
}
stage(‘Build’)
{
    Sh “sh untilloop.sh”
}
Stage(‘Array’)
{
    Sh “sh array”
}
Stage(Notify”)
{
    Sh ‘mail - s “the job ran fine” sanjaysunar933 @gmail.com’

    }
}