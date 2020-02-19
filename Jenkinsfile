node () {
    stage ('Checkout'){
        checkout scm
    }
    stage ('Build'){
        sh "sh untilloop.sh"
    }
    stage ('Array'){
        sh "sh Array.sh"
    }
    stage ('Notify'){
        sh 'mail -s "The job was good" liverpoolfctillidie708@gmail.com'
    }
}