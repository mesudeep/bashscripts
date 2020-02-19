node(){
    stage('Checkout'){
        checkout scm
    }
    stage('printing Parameter'){
        sh "echo ${Environment}"

    }
    stage('Build'){
         sh "sh untilloop.sh"
    }
    stage('Array'){
        sh "sh array"
    }
    stage('Notify'){
        sh 'mail -s "the job ran fine" meliverpool36@gmail.com'
    }

}