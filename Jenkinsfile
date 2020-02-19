node(){
    stage('Checkout'){

        checkout scm

    }
    stage('printing parameter'){
        sh "echo ${environment}"
    }
    stage('Build'){
        sh "sh untilloop.sh"

    }
    if (params.environment == 'dev'){
        stage('Array'){
            sh "sh array"
        }
    }
    stage('Notify'){
        sh 'mail -s “the job ran file” timalsinasrijana77@gmail.com'

    }
}